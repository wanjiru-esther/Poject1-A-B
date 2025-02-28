# Poject1-A-B

## Project Overview
This project explores fundamental operating system concepts, including multi-threading, synchronization, and inter-process communication (IPC). The project is divided into two major parts: ProjectA & ProjectB

**Project A:** Multi-Threading Implementation (Four Phases)
This part demonstrates threading concepts and synchronization. Each phase builds upon the previous one to create a complete threading implementation:
Phase 1: Basic Thread Operations
Objective: Create threads that perform concurrent operations for cookie jar access. 
Cookie Example: Implement threads for individual cookie operations in a cookie jar (e.g., adding or removing cookies concurrently)
Phase 2: Resource Protection
Objective: Implement synchronization mechanisms like mutexes to protect the cookie jar.
Cookie Example: Protect cookie access in a shared cookie jar with mutexes
Phase 3: Deadlock Creation
Objective: Simulate deadlocks by introducing resource conflicts in cookie transactions.
Cookie Example: Show deadlock when multiple threads are trying to access the cookie jar simultaneously with insufficient resource management
Phase 4: Deadlock Resolution
Objective: Implement solutions to resolve deadlocks in cookie jar operations.
Cookie Example: Resolve deadlock by introducing a timeout mechanism in cookie transactions or better synchronization to prevent simultaneous access conflicts

**Project B:** Inter-Process Communication (IPC)
This is a separate project focused specifically on understanding how processes communicate through pipes. Using a Producer-Consumer model, the Producer runs a command (ls) and then sends the output through a pipe, and the Consumer processes the data by reading from the pipe.
Inter-Process Communication (IPC): The project demonstrates communication between two processes using pipes.
Data Flow: The program passes data between the producer and consumer via standard input and output streams.
Producer-Consumer Pattern: The producer generates data using the ls command, and the consumer reads and processes the data.

**Prerequisites: For both projects**
Virtualization Tools: This project will leverage the VMWare Virtualization tool.
.NET SDK for C#: Used for compiling C# programs.
IDE: Visual Studio Code or other code editors.
Linux Distribution: Ubuntu or any other Linux distribution. This project will leverage Ubuntu

# Installation Instructions:
**Step1:** Install Linux Distribution (if not already installed):
Visit https://www.vmware.com/products/desktop-hypervisor/workstation-and-fusion, the official website, and install the VMware virtualization tool.
This project assumes you are using Ubuntu or a similar Linux environment. After VMWare Installation, Install Ubuntu from this official website https://ubuntu.com/download/desktop

**Step2**: Install Visual Studio Code:
   - Install Visual Studio Code from https://visualstudio.microsoft.com/downloads/ Microsoft website or use a different IDE of your choice.
     
**Step3**: Install .NET SDK for C#:
   - Follow the installation instructions on the https://dotnet.microsoft.com/en-us/download website to install the SDK on your Linux machine. Choose a Linux Distribution of your choice.


**Step-by-step Instructions for Building and Running the program.**
#To run  both projects on the VMware, Ubuntu terminal:

**Clone the Repository:**
Clone like this: git clone https://github.com/your-username/your-repository.git
Replace your-username and your-repository with the actual GitHub details.

**Navigate to the Project Directory:**
After cloning, navigate to the project directory where each project file is located.

**Build the Program Using the .NET SDK:**
Ensure you have the .NET SDK installed. You can verify this by running dotnet --version.
Build the program by running the following command: dotnet build
Run the Program: After building the program, run it using: dotnet run

**Note:** 
For ProjectA, the main Program.cs file can execute all four phases in sequence. This approach will keep the phases modular but run them all in a single execution flow.


## License
This project is open-source and can be modified and reused under the MIT License.
