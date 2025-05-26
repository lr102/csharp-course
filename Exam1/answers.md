# Exam 1

## How to present?

- You need to fork the entire project or update your fork
- Create a new branch named `exam1`
- You have to solve the exam in `CSharpCourse/Exam1/`
- Create a new console application here (it can be a single project since we don't need unit testing)

## What each solution should include?

- The name of the problem
- Why you chose the data structure

## Do you want to create a project using commands?

> You can go to the `SingleResponsibility` project there you have an example in the `README.md` file.

## Problems

### 1. Expression Evaluator with Undo

ANSWER: I'll use a stack, as it requires to undo the result. There is no need to use trees as we receive two parameters each time.

### 2. Print Server Load Balancer

ANSWER: If we need to ensure FIFO, then we need to use a queue.

### 3. Browser History Navigation

ANSWER: For this I would use a double linked list, as we can move from a node to is previous or next element, according to our needs.

### 4. Single responsibility principle

Task

Refactor this ProcessOrders method so that each class has one responsibility (Fix any errors you find)

> Note: This runs itself you don't need to create an orchestator. Just split in single methods or classes (interfaces)

```csharp


```