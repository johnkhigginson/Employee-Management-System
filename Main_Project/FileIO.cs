using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace Main_Project
{
    internal sealed class FileIO : object, iFileAccess
    {
        private BinaryFormatter binary = new BinaryFormatter();

        public SortedDictionary<string, Employee> EmployeeDB
        {
            get;
            set;
        }

        private readonly static Lazy<FileIO> lazy;
        public static FileIO Instance
        {
            get
            {
                return FileIO.lazy.Value;
            }
        }

        public Stream fileStream { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        static FileIO()
        {
            FileIO.lazy = new Lazy<FileIO>(() => new FileIO());
        }

        private struct SerializeData
        {
            private SortedDictionary<string, Employee> empData;

            public SerializeData(SortedDictionary<string, Employee> data)
            {
                this.empData = data;
            }

            public SortedDictionary<string, Employee> GetData()
            {
                return this.empData;
            }

            public void SetData(SortedDictionary<string, Employee> data)
            {
                this.empData = data;
            }
        }
        public void OpenFileDB()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                InitialDirectory = "c://",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.fileStream = openFile.OpenFile();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Could not read file.");
                }
            }
        }

        public void SaveFileDB()
        {
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.fileStream = saveFile.OpenFile();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Could not save to file.");
                }
            }
        }

        public void ReadDB()
        {
            try
            {
                FileIO.SerializeData serializeData = (FileIO.SerializeData)this.binary.Deserialize(this.fileStream);
                this.EmployeeDB = serializeData.GetData();
                this.fileStream.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error: Could not read from file.");
            }
        }

        public void WriteDB()
        {
            FileIO.SerializeData serializeData = new FileIO.SerializeData(this.EmployeeDB);
            try
            {
                this.binary.Serialize(this.fileStream, serializeData);
                this.fileStream.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Could not save to file.");
            }
        }
    }
}
