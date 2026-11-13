#include <stdio.h>

#define MAX 5
#define EMPTY (-1)

int stack[MAX];
int top = EMPTY;

void push(int value);
void pop();
void Display();
int main()
{
    int choice, value;
    do
    {
        printf("\n---STACK OPERATION---\n1. PUSH\n2. POP\n3. EXIT\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch(choice)
        {
            case 1:
            {
                printf("Enter value to push: ");
                scanf("%d", &value);

                push(value);
                Display();
                break;
            }
            case 2:
            {
                pop();
                Display();
                break;
            }
            case 3: 
            {
                printf("Program terminated");
                break;
            }
            default: 
            {
                printf("Invalid choice!");
                break;
            }
        }
    } while (choice != 3);
}

void push(int value)
{
    if (top >= MAX - 1)
    {
        printf("\nStack Overflow\n");
        return;
    }
    top++;
    stack[top] = value;
}

void pop()
{
    if (top == EMPTY)
    {
        printf("\nStack Underflow\n");
        return;
    }
    top--;
}

void Display()
{
    if (top == EMPTY)
    {
        printf("\nThe stack is empty!\n");
        return;
    }
    printf("\nStack Elements: \n");
    for (int i = top; i >= 0; i--)
        printf("%d\n", stack[i]);
}