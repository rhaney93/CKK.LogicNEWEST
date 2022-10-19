using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;
using CKK.Logic.Models;
using CKK.Persistence.Interfaces;

namespace CKK.Persistance.Models
{
    public class FileStore : IStore, ISavable, ILoadable
    {
        public readonly string FilePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Persistence" + Path.DirectorySeparatorChar + "StoreItems.dat";
        
        private List<StoreItem> Items;
        static int IdCounter = 1;
        static int generateId()
        {
            return IdCounter++;
        }

        public FileStore()
        {
            this.CreatePath();
            this.Items = new List<StoreItem>();
        }
        

        public StoreItem AddStoreItem(Product product, int quantity)
        {
            if (product.Id == 0)
            {
                product.Id = generateId();
            }
            var existingItem = FindStoreItemById(product.Id);

            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException("Cannot be a negative number");
            }

            if (existingItem == null)
            {
                var newItem = new StoreItem(product, quantity);
                Items.Add(newItem);
                this.Save();
                return newItem;
            }
            else
            {
                // !!!: Removed the bit where we add the quantity in favor of just setting
                //      to what the text field says.
                existingItem.Quantity = quantity;
                this.Save();
                return existingItem;
            }
            
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException("Cannot be a negative number");
            }
            return Items.Find(i => i.Product.Id == id);
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var itemToRemove = FindStoreItemById(id);

            if (itemToRemove != null)
            {
                var nextQuantity = Math.Max(itemToRemove.Quantity - quantity, 0);
                itemToRemove.Quantity = nextQuantity;

                if (nextQuantity < 0)
                {
                    throw new ProductDoesNotExistException("Cannot be a negative number");
                }
            }
            else if (itemToRemove == null)
            {
                throw new ProductDoesNotExistException("Cannot be a negative number");
            }
            else
            {
                return itemToRemove;
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            this.Save();
            return itemToRemove;
            
        }

        public void Load()
        {
            try
            {
                FileStream readStream = new FileStream(this.FilePath, FileMode.Open);
                BinaryFormatter loadFormatter = new BinaryFormatter();
                try
                {
                    this.Items = (List<StoreItem>)loadFormatter.Deserialize(readStream);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    readStream.Close();
                }
            } catch (Exception e)
            {
                Console.WriteLine("Failed to load from file path. Reason: " + e.Message);
            }

        }
        public void Save()
        {
            if (File.Exists(this.FilePath))
            {
                File.Delete(this.FilePath);
            }

            FileStream writeStream = new FileStream(this.FilePath, FileMode.Create);
            
            BinaryFormatter saveFormatter = new BinaryFormatter();
            try
            {
                saveFormatter.Serialize(writeStream, this.Items);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                writeStream.Close();
            }
        }

        private void CreatePath()
        {
            string fileDirectoryPath = Path.GetDirectoryName(this.FilePath);
            if (!Directory.Exists(fileDirectoryPath))
            {
                Directory.CreateDirectory(fileDirectoryPath);
            }
        }

        public void DeleteStoreItem(int id)
        {
            Items = Items.Where(i => i.Product.Id != id).ToList();
            this.Save();
        }

        public List<StoreItem> GetAllProductsByName(string name)
        {
            return this.GetStoreItems()
                .FindAll(item => item.Name.ToLower().Contains(name.ToLower()))
                .ToList();
        }

        public List<StoreItem> GetProductsByQuantity()
        {
            return this.GetStoreItems()
                .OrderBy(item => item.Quantity)
                .ToList();
        }

        public List<StoreItem> GetProductsByPrice()
        {
            return this.GetStoreItems()
                .OrderBy(item => item.Price)
                .ToList();
        }
    }
}
