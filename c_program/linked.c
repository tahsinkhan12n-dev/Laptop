#include <stdio.h>
#include <stdlib.h>

typedef struct node
{
    int data;
    struct node* next;
} node;


node* createNode(int data)
{
    node* newNode = malloc(sizeof(node));
    if (newNode == NULL)
    {
        printf("Allocation faild!");
        exit(1);
    }
    newNode->data = data;
    newNode->next = NULL;

    return newNode;
}

void printLinkedList(node* head)
{
    node* tmp = head;
    printf("\n");
    while (tmp != NULL)
    {
        printf("%d -> ", tmp->data);
        tmp = tmp->next;
    }
    printf("null");
}

node* insertAtEnd(node* head, int data)
{
    node* newNode = createNode(data);
    if (head == NULL)
    {
        head = newNode;
    }
    else
    {
        node* tmp = head;
        while (tmp->next != NULL)
        {
            tmp = tmp->next;
        }
        tmp->next = newNode;
    }
    return head;
}

node* insertAtFirst(node* head, int data)
{
    node* newNode = createNode(data);
    newNode->next = head;
    return newNode;
}

node* insertAtPosition(node* head, int data, int position)
{
    node* newNode = createNode(data);
    if (position < 1)
    {
        printf("Invalid position\n");
        return head;
    }
    if (position == 1)
    {
        return insertAtFirst(head, data);
    }
    node* tmp = head;
    for (int i = 1; i < position - 1 && tmp != NULL; i++) {
        tmp = tmp->next;
    }

    if (tmp == NULL)
    {
        printf("Position out of range!\n");
        free(newNode);
        return head;
    }
    newNode->next = tmp->next;
    tmp->next = newNode;
    return head;
}

int main()
{
    node* head = NULL;
    int choice, data;

    do 
    {
        printf("\n1. Insert at fisrt\n2. Insert at end\n3. Insert at a position\n4. Display linked list\n5. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice)
        {
            case 1:
            {
                printf("Enter a number: ");
                scanf("%d", &data);
                head = insertAtFirst(head, data);
                break;
            }
            case 2:
            {
                printf("Enter a number: ");
                scanf("%d", &data);
                head = insertAtEnd(head, data);
                break;
            }
            case 3:
            {
                int posi;
                printf("Enter the position and number: ");
                scanf("%d %d", &posi, &data);
                head = insertAtPosition(head, data, posi);
                break;
            }
            case 4:
            {
                printLinkedList(head);
                break;
            }
            case 5:
            {
                printf("Program terminitated!\n");
                break;
            }
            default:
            {
                printf("Invalid choice\n");
                break;
            }
        }
    } while(choice != 5);
}