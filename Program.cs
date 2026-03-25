namespace Verifica_
{
    internal class Program
    {
        //To whoever has to correct this code,May God aid your wretched soul
        static int[] Same_letter(string[,] matrix, int row)
        {
            string searched_letter = "";
            int b = 0;
            int[] result= new int[matrix.GetLength(1)];
            string[] row_array=new string[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++) 
            { 
                row_array[i] = matrix[row, i];
            }
            for (int i = 0;i < row_array.Length; i++)
            {
                searched_letter += row_array[i];
                for (int j = 0; j < row_array.Length; j++) 
                {
                    if (j == i)
                    {
                        j++;
                        if(j == matrix.GetLength(1))
                        {
                            j = 0;
                        }                     
                    }
                    if (searched_letter == row_array[j])
                    {
                        result[b] = i;
                        b++;
                    }
                }              
            }
            return result;
        }
        static string One_finder(int x,int y,int [,] matrix)
        {
            int x_1 = 0, y_1 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 1)
                    {
                        x_1 = i;
                        y_1 = j;
                    }
                }
            }
            if(x_1 == x &&y_1 == y)
            {
                return "Found!";
            }
            else if(y_1 == y)
            {
                return "Same column";
            }
            else if (y_1 > y)
            {
                return "Right!";
            }
            
            return "Left!";
            
        }
       static bool Binary_equal(int[,] matrix)
       {
            bool done=false;
            int[] sample = new int[matrix.GetLength(1)];
            int counter = 0,c=0;
            while (done == false) 
            {
              
            int[] searched = new int[matrix.GetLength(1)];
            counter = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sample[j] = matrix[c, j];

            }
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i == c)
                    {
                        i++;
                        if (i == matrix.GetLength(0))
                        {
                            done=true;
                        }
                    }
                    for (int j=0;j<matrix.GetLength(1); j++)
                    {
                        sample[j]=matrix[i,j];
                    }
                    for (int a = 0; a < sample.Length; a++)
                    {
                        if (sample[a] == searched[a])
                        {
                            counter++;
                        }
                    }
                    if (counter == sample.Length)
                    {
                        return true;
                    }
                }
                    c++;
            }
            return false;     
       }
           
       
        static void Main(string[] args)
        { 


            int[,] matrix = { { 0, 0, 1, 1 }, { 0, 1, 1, 1 }, { 0, 1, 1, 0} };
            Console.WriteLine(Binary_equal(matrix));
        }
    }
}
