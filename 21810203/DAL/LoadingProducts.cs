namespace _21810203.DAL
{
    public class LoadingProducts
    {
        public string LoadingProductsFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            sr.Close();
            return lines;
        }
        public void savingProduct(string lines)
        {
            StreamWriter sw = new StreamWriter(lines);
            sw.WriteLine();
            sw.Close();
        }
    }
}
