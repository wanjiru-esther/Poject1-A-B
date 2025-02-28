# Poject1-A-B

## Project Overview
This project explores fundamental operating system concepts, including multi-threading, synchronization, and inter-process communication (IPC). The project is divided into two major parts:

**Project A:** Multi-Threading Implementation (Four Phases)
This part demonstrates threading concepts and synchronization. Each phase builds upon the previous one to create a complete threading implementation:
1. Phase 1: Basic Thread Operations
2. Phase 2: Resource Protection
3. Phase 3: Deadlock Creation
4. Phase 4: Deadlock Resolution

**Project B:** Inter-Process Communication (IPC)
This is a separate project focused specifically on understanding how processes communicate through pipes.

**Prerequisites**
Virtualization Tools: This project will leverage the VMWare Virtualization tool.
.NET SDK for C#: Used for compiling C# programs.
IDE: Visual Studio Code or other code editors.
Linux Distribution: Ubuntu or any other Linux distribution. This project will leverage Ubuntu

# Installation Instructions:
**Step1:** Install Linux Distribution (if not already installed):
Visit https://www.vmware.com/products/desktop-hypervisor/workstation-and-fusion official website do install VMWare virtualization tool.
This project assumes you are using Ubuntu or a similar Linux environment. After VMWare Installation, Install Ubuntu from this official website https://ubuntu.com/download/desktop

**Step2**: Install Visual Studio Code:
   - Install Visual Studio Code from https://visualstudio.microsoft.com/downloads/ Microsoft website or use a different IDE of your choice.
**Step3**: Install .NET SDK for C#:
   - Follow the installation instructions on the https://dotnet.microsoft.com/en-us/download website to install the SDK on your Linux machine. Choose a Linux Distribution of your choce.

# Project Breakdown
Project A:
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

NOTE: Running program: Use the main Program.cs file to run the all 4 Phases files in one main file. Each phase has its own file

**Project B: **
Inter-Process Communication (IPC) with Pipes
Objective: Use pipes for data transfer between processes in a custom IPC example (such as communication between two processes manipulating the cookie jar).
Instructions for Setup and Running the Program:
1. The Instructions for Setup are the same as for Project A
2. Clone the repository to your local machine
3. Build the program using the .NET SDK
4. Run the program: Use the Program.cs. The main file includes the different IPC tasks.
5.Test the IPC functionality after running the program. Verify that data correctly transfers between processes using pipes


## License
This project is open-source and can be modified and reused under the MIT License.
