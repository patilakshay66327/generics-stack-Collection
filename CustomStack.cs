using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom_Collection_Stack
{
    class CustomStack1<T> where T : IEnumerable
    {
        int size;
        T[] stack;
        int top;

    
        public CustomStack1(int stackSize)
        {
            size = stackSize;
            stack = new T[size];
        }

        public int Push(T element)
        {
            if (top == size - 1)
            {
                return -1;
            }
            else
            {
                top++;
                stack[top] = element;
            }

            return 0;
        }


        public T Pop()
        {
            T popValue;
            T temp = default(T);

            if (!(top <= 0))
            {
                popValue = stack[top];
                top--;
                return popValue;
            }
            return temp;
        }

        public void Peek()
        {
            Console.WriteLine("Top Elemet into stack is : "+stack[top]);    
        }

        /*public void clearStack()
        {
            T popResult;
            for (int i = 0;i < top;i++)
            {
               popResult = Pop();
            }
            Console.WriteLine("last Element in stack : " + popResult);

        }*/
    }

    class CustomStack
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of stack : ");
            size = int.Parse(Console.ReadLine());

            CustomStack1<string> customStack = new CustomStack1<string>(20);

            int n;
            do
            {
                Console.WriteLine("1 : push element");
                Console.WriteLine("2 : pop element");
                Console.WriteLine("3 : Peek Top Element");
                Console.WriteLine("4 : Clear");
                Console.WriteLine("Enter your Choice : ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the elemet to push : ");
                        string temp = Console.ReadLine();
                        int result = customStack.Push(temp);

                        if (result != -1)
                        {
                            Console.WriteLine("Elemet Successfullly Push into stack.");
                        }
                        else
                        {
                            Console.WriteLine("Stack is full.");
                        }

                        break;

                    case 2:
                        string popResult = customStack.Pop();

                        if (popResult != null)
                        {
                            Console.WriteLine("Delete Element :" + popResult);
                        }
                        else
                        {
                            Console.WriteLine("Stack is underflow");
                        }
                        break;

                    case 3:
                        customStack.Peek();
                        break;

                    case 4:
                        //  while (customStack.Count > 0)
                        //   Console.WriteLine(customStack.Pop());
                        //customStack.clear();
                           
                        break;

                }
                Console.WriteLine("Do you want to continue then press 0.");
                n = int.Parse(Console.ReadLine());
            } while (n == 0);

        }
        }
    }

