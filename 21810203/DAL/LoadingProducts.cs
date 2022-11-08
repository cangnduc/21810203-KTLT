namespace _21810203.DAL
{
    public class LoadingProducts
    {
        public static string LoadingProductsFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            sr.Close();
            return lines;
        }
        public void savingProduct(string path, string lines)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(lines);
            sw.Close();
        }
    }
}
