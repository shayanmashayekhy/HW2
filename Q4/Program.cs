class snailarray
{
	static int R = Convert.ToInt32(Console.ReadLine());
	static int C = Convert.ToInt32(Console.ReadLine());
	static void formSpiralMatrix(int[] arr,
								int[,] mat)
	{
		int top = 0,
			bottom = R - 1,
			left = 0,
			right = C - 1;

		int index = 0;

		while (true)
		{
			if (left > right)
				break;
			for (int i = left; i <= right; i++)
				mat[top, i] = arr[index++];
			top++;

			if (top > bottom)
				break;

			for (int i = top; i <= bottom; i++)
				mat[i, right] = arr[index++];
			right--;

			if (left > right)
				break;

			for (int i = right; i >= left; i--)
				mat[bottom, i] = arr[index++];
			bottom--;

			if (top > bottom)
				break;

			for (int i = bottom; i >= top; i--)
				mat[i, left] = arr[index++];
			left++;
		}
	}
	static void printSpiralMatrix(int[,] mat)
	{
		for (int i = 0; i < R; i++)
		{
			for (int j = 0; j < C; j++)
				Console.Write(mat[i, j] + " ");
			Console.WriteLine();
		}
	}
	public static void Main(String[] args)
	{
		int[] arr = { 1, 2, 3, 4, 5, 6,
					7, 8, 9, 10, 11, 12,
					13, 14, 15, 16, 17, 18 , 1 };

		int[,] mat = new int[R, C];

		formSpiralMatrix(arr, mat);
		printSpiralMatrix(mat);
	}
	
}


