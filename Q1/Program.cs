Main();
     static void Main()
    {
        int[] arr1 = new int[10000];
        int i, mn, n, j, tmp,Count = 0;


        Console.WriteLine("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Input {0} elements in the array :", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("1 - minimum element");
        Console.WriteLine("2 - sorted element");
        Console.WriteLine("3 - reverse sorted element");
        Console.WriteLine("4 - duplicat element");
        Console.WriteLine("5 - duplicat element in two array");
        Console.WriteLine("please enter an action :");
        int action = Convert.ToInt32(Console.ReadLine());
        switch (action)
        {
            case 1://min
                {
                    
                    mn = arr1[0];

                    for (i = 1; i < n; i++)
                    {
                        if (arr1[i] < mn)
                        {
                            mn = arr1[i];
                        }
                    }
                    Console.Write("Minimum element is : {0}", mn);
                    break;
                }
            case 2://sorted
                {
                    
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                            if (arr1[j] < arr1[i])
                            {
                                tmp = arr1[i];
                                arr1[i] = arr1[j];
                                arr1[j] = tmp;
                            }
                        }
                    }

                    Console.WriteLine("Elements of array in sorted ascending order:");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("{0}  ", arr1[i]);
                    }

                    break;
                }
            case 3://reverse sorted
                {
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                            arr1[i] = arr1[j];
                            if (arr1[i] == arr1[j])
                            {
                                Count++;
                                break;
                            }
                        }
                    }
                   
                    Console.Write("\n\nThe values store into the array in reverse are :\n");
                    for (i = n - 1; i >= 0; i--)
                    {
                        Console.Write("{0} ", arr1[i]);
                    }
                    break;
                }
            case 4://duplicat
                {
                    
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                            if (arr1[i] == arr1[j])
                            {
                             
                                Count++;
                                
                            }
                        }
                    }
                    Console.WriteLine("duplicate elements found in array :" + Count );
                    break;
                }
            case 5:
                {
                    int[] arr2 = new int[10000];

                    Console.WriteLine("Input the number of elements to be stored in the array2 :");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Input {0} elements in the array2 :", n);
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        arr2[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                           
                            if (arr1[i] == arr2[j])
                            {
                                Count++;
                                
                            }
                        }
                    }
                    Console.WriteLine("duplicate elements found in index :" + Count );
                    
                    break;
                  
                }
            default:
                Console.WriteLine("action not valued");
                break;







        }




    }
