using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Holds connection to DB
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.PockyLearnDBConnectionString"].ConnectionString;

            // Initialize connection
            sqlConnection = new SqlConnection(connectionString);

            // Call method that displays store names
            DisplayStores();

            // Method that displays every product in list
            DisplayAllProducts();
        }

        // Tambahkan variabel boolean untuk menandakan apakah pembaruan inventory harus dilakukan
        private bool updateInventoryOnSelectionChange = true;

        private void storeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Panggil DisplayStoreInventory hanya jika variabel updateInventoryOnSelectionChange true
            if (updateInventoryOnSelectionChange)
            {
                DisplayStoreInventory();
            }
        }

        // Method that will display store names
        private void DisplayStores()
        {
            // Surround DB interacting code with try catch
            try
            {
                string query = "SELECT * FROM store";
                // Connect to DB, run query and then close DB connection
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                // Use our query and connection to populate the list
                // with store names
                using (sqlDataAdapter)
                {
                    // Acts as an interface between DB and this code
                    DataTable storeTable = new DataTable();

                    sqlDataAdapter.Fill(storeTable);

                    // Define the column we are displaying in listbox
                    storeList.DisplayMemberPath = "Name";

                    // Define what is unique about each item in the list
                    storeList.SelectedValuePath = "Id";

                    // The content we will use to populate the list
                    storeList.ItemsSource = storeTable.DefaultView;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        


        // Displays the shoes the store has in inventory
        // Method that will display store names
        private void DisplayStoreInventory()
        {
            // Surround DB interacting code with try catch
            try
            {
                // Find shoes that match for the specific product
                // by using the store id clicked in the listbox
                string query = "SELECT * FROM Product p inner join StoreInventory si ON p.Id = si.ProductId WHERE si.StoreId = @StoreId";

                // To use the passed variable we must use SqlCommand
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Connect to DB, run query and then close DB
                // connection
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Use our query and connection to populate the list
                // with store names
                using (sqlDataAdapter)
                {
                    // We need the ID clicked to perform our query
                    sqlCommand.Parameters.AddWithValue("@StoreId", storeList.SelectedValue);

                    // Acts as an interface between DB and this code
                    DataTable inventoryTable = new DataTable();

                    sqlDataAdapter.Fill(inventoryTable);

                    // Define the column we are displaying in listbox
                    storeInventory.DisplayMemberPath = "Brand";

                    // Define what is unique about each item in the list
                    storeInventory.SelectedValuePath = "Id";

                    // The content we will use to populate the list
                    storeInventory.ItemsSource = inventoryTable.DefaultView;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Method that will display all products
        private void DisplayAllProducts()
        {
            try
            {
                string query = "SELECT * FROM Product";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable productTable = new DataTable();

                    sqlDataAdapter.Fill(productTable);

                    productList.DisplayMemberPath = "Brand";

                    productList.SelectedValuePath = "Id";

                    productList.ItemsSource = productTable.DefaultView;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddStore(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("AddStoreClicked");
            try
            {
                sqlConnection.Open();

                // Add list of parameters using textbox names
                // You also have to define data type
                List<SqlParameter> parameters = new List<SqlParameter>(){
                    new SqlParameter("@Name", SqlDbType.NVarChar) {Value = storeName.Text},
                    new SqlParameter("@Street", SqlDbType.NVarChar) {Value = storeStreet.Text},
                    new SqlParameter("@City", SqlDbType.NVarChar) {Value = storeCity.Text},
                    new SqlParameter("@State", SqlDbType.NChar) {Value = storeState.Text},
                    new SqlParameter("@Zip", SqlDbType.Int) {Value = storeZip.Text}
                };

                // Make sure they are in the same order as the DB
                string query = "INSERT INTO Store (Name, Street, City, State, Zip) VALUES (@Name, @Street, @City, @State, @Zip)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Used to add a range of values
                sqlCommand.Parameters.AddRange(parameters.ToArray());

                // Execute the INSERT command
                sqlCommand.ExecuteNonQuery();

                storeName.Text = "";
                storeStreet.Text = "";
                storeCity.Text = "";
                storeState.Text = "";
                storeZip.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayStores();
            }
        }

        private void AddInventory(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("AddInventoryClicked");
            try
            {
                // Will be defining variable values using the
                // items selected in the list boxes
                string query = "INSERT INTO StoreInventory VALUES (@StoreId, @ProductId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@StoreId", storeList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ProductId", productList.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayStoreInventory();
            }
        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("AddProductClicked");
            try
            {
                // Add list of parameters using textbox names
                // You also have to define data type
                List<SqlParameter> parameters = new List<SqlParameter>(){
                    new SqlParameter("@Manufacturer", SqlDbType.NVarChar) {Value = prodManu.Text},
                    new SqlParameter("@Brand", SqlDbType.NVarChar) {Value = prodBrand.Text}
                };

                // Make sure they are in the same order as the DB
                string query = "INSERT INTO Product VALUES (@Manufacturer, @Brand)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                // Used to add a range of values
                sqlCommand.Parameters.AddRange(parameters.ToArray());

                DataTable productTable = new DataTable();

                // Abbreviated way to use adapter
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand)) adapter.Fill(productTable);

                prodManu.Text = "";
                prodBrand.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayAllProducts();
            }
        }


        private void DeleteStore(object sender, RoutedEventArgs e)
        {
            try
            {
                if (storeList.SelectedValue != null)
                {
                    // Nonaktifkan event SelectionChanged sementara
                    storeList.SelectionChanged -= storeList_SelectionChanged;

                    // Tambahkan konfirmasi penghapusan
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this store?", "Delete Store", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        sqlConnection.Open();

                        string query = "DELETE FROM Store WHERE Id = @StoreId";

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@StoreId", storeList.SelectedValue);

                        sqlCommand.ExecuteNonQuery();

                        // Set updateInventoryOnSelectionChange ke false setelah penghapusan store
                        updateInventoryOnSelectionChange = false;

                        // Tidak perlu memanggil DisplayStoreInventory() di sini karena toko sudah dihapus
                        // DisplayStores() sudah memuat ulang daftar toko yang diperbarui
                        DisplayStores();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a store to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Aktifkan kembali event SelectionChanged
                storeList.SelectionChanged += storeList_SelectionChanged;

                sqlConnection.Close();
            }

            // We need to update StoreInventory so that when a
            // store is deleted entries in StoreInventory are also
            // deleted for the deleted store
            // Right Click -> StoreInventory in Server Explorer
            // Open Table Definition
            // Add ON DELETE CASCADE end of both Foreign Keys
        }

        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Product WHERE Id = @ProductId";

                // Simple way to execute a query without adapter
                // Open and close on our own
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                // Pass value for query
                sqlCommand.Parameters.AddWithValue("@ProductId", productList.SelectedValue);

                // Execute query
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // This throws an error because the store inventory
                // list expects a default store selection
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                // Update the store listbox
                DisplayAllProducts();
                DisplayStoreInventory();
            }
        }

        private void DeleteInventory(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM StoreInventory WHERE ProductId = @ProductId";

                // Simple way to execute a query without adapter
                // Open and close on our own
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                // Pass value for query
                sqlCommand.Parameters.AddWithValue("@ProductId", storeInventory.SelectedValue);

                // Execute query
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // This throws an error because the store inventory
                // list expects a default store selection
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                DisplayStoreInventory();
            }
        }
    }
}