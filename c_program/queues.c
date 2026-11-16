#include <stdio.h>

#define MAX 5

typedef struct
{
    int queues[MAX];
    int front;
    int size;
} queue;

void enqueue(queue* q, int data);
void displayQueue(queue* q);
void dequeue(queue* q);

int main ()
{
    int choice;
    queue myQueue = {.front = 0, .size = 0};
    do
    {
        int data;
        printf("\n--Queues Oparations--\n1. Enqueue\n2. Dequeue\n3. Exit\n");
        scanf("%d", &choice);

        switch (choice)
        {
            case 1:
            {
                printf("Enter a value in queue: ");
                scanf("%d", &data);

                enqueue(&myQueue, data);
                displayQueue(&myQueue);
                break;
            }
            case 2:
            {
                dequeue(&myQueue);
                displayQueue(&myQueue);
                break;
            }
            case 3:
            {
                printf("Program terminated!");
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

void enqueue(queue* q, int data)
{
    if (q->size == MAX)
    {
        printf("\nQueue is full\n");
        return;
    }
    q->queues[(q->front + q->size) % MAX] = data;
    q->size++;
}

void dequeue(queue* q)
{
    if (q->size == 0)
    {
        printf("\nQueue is empty!\n");
        return;
    }
    q->front = (q->front + 1) % MAX;
    q->size--;
}

void displayQueue(queue* q)
{
    if (q->size == 0)
    {
        printf("\nQueue is empty!\n");
        return;
    }
    for (int i = 0; i < q->size; ++i)
    {
        printf("%d ", q->queues[(q->front + i) % MAX]);
    }
}