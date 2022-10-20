# **ABOUT DOCKER**
This open-source containerization platform is based on Linux that is useful for programmers to design, develop and run the package applications for deployment using containers. Basically, it divides the application’s performance into various components which able to process independently when needed. Docker containers offer efficient development and test, quick execution, interoperability, and more. With the docker environment, the applications/services can run with individual host access.

**_WHY ONE SHOULD LEARN MICROSERVICE, DOCKER, AND KUBERNETES?_**  
We have noticed that technologies today have evolved a lot to suit the requirements of today's needs of customers and projects. So that monolithic architectures are replaced with microservices and docker/Kubernetes open-source platforms.

## **Introduction to Containerization and Docker**
### **Understanding VM's and Containers.**
  - Virtual machines and Containers are two ways of deploying multiple, isolated services on a single platform. Both VMs and containers use virtualization.
  - What Is Virtualization?
    - Virtualization is the process of creating a simulated computing environment that’s abstracted from the physical computing hardware—essentially a computer-generated computer. Virtualization allows you to create multiple, virtual computing instances from the hardware and software components of a single machine.
  - What Is a Hypervisor?
    - The software that enables virtualization is called a hypervisor. It’s a lightweight software layer that sits between the physical hardware and the virtualized environments and allows multiple operating systems (OS) to run in tandem on the same hardware.
  - What Are Virtual Machines?
    - The computer-generated computers that virtualization makes possible are known as virtual machines (VMs)—separate computers running on hardware that is actually contained in one physical computer.
    - Each VM requires its own OS. The OS and any applications running on an individual VM share hardware resources from a single host server. VM is isolated from its neighbors.
    - VMs, however, can take up a lot of system resources. Each VM runs not just a full copy of an OS, but a virtual copy of all the hardware that the operating system needs to run. It’s why VMs are sometimes associated with the term “monolithic”—they’re single, all-in-one units commonly used to run applications built as single, large files.
  - What Are Containers?
    - With containers, instead of virtualizing the underlying computer like a VM, just the OS is virtualized. A container is a runnable instance of an image.
    - Containers sit on top of a physical server and its host OS—typically Linux or Windows. Each container shares the host OS kernel and, usually, the binaries and libraries, too. Containers are thus exceptionally light—they are only megabytes in size and take just seconds to start.
    - With containers, applications could be broken down into their smallest component parts or “services” that serve a single purpose, and those services could be developed and deployed independently of each other instead of in one monolithic unit.
![image](https://user-images.githubusercontent.com/84464752/196883694-23160e2d-9ad3-4063-a6d7-22cb0c6bece5.png)


### **Benefits of Containerization**
  - Reduced IT management resources.
  - Faster spin ups.
  - Smaller size means one physical machine can host many containers.
  - Reduced & simplified security updates.
  - Less code to transfer, migrate, and upload workloads.


### **What is Docker?**
  - Docker is an open platform for developing, shipping, and running applications. Docker enables you to separate your applications from your infrastructure so you can deliver software quickly.
  - Docker provides the ability to package and run an application in a loosely isolated environment called a container. The isolation and security allows you to run many containers simultaneously on a given host. Containers are lightweight and contain everything needed to run the application.
 

### **Docker Benefits.**
  - Fast, consistent delivery of your applications.
    - Containers are great for continuous integration and continuous delivery (CI/CD) workflows.
    - When developers find bugs, they can fix them in the development environment and redeploy them to the test environment for testing and validation.
    - When testing is complete, getting the fix to the customer is as simple as pushing the updated image to the production environment.
  - Responsive deployment and scaling
    - Docker containers can run on a developer’s local laptop, on physical or virtual machines in a data center, on cloud providers, or in a mixture of environments.
  - Running more workloads on the same hardware -Since it is lightweight you can use more server capability for large no. of applications.
  

### **Docker Architecture**
  - Docker follows Client-Server architecture, which includes the three main components that are Docker Client, Docker Host, and Docker Registry.

![image](https://user-images.githubusercontent.com/84464752/196906491-f6b33e02-b839-4e63-b1ec-62a08660835f.png)

  - **The Docker daemon**:-  
    The Docker daemon (dockerd) listens for Docker API requests and manages Docker objects such as images, containers, networks, and volumes. A daemon can also communicate with other daemons to manage Docker services.
  - **Docker Client**:-   
  Docker client uses commands and REST APIs to communicate with the Docker Daemon (Server). When a client runs any docker command on the docker client terminal, the client terminal sends these docker commands to the Docker daemon. Docker daemon receives these commands from the docker client in the form of command and REST API's request.
    Note: Docker Client has an ability to communicate with more than one docker daemon. 
    Docker Client uses Command Line Interface (CLI) to run the following commands -docker build, docker pull, docker run
  - **Docker Host**:- 
  Docker Host is used to provide an environment to execute and run applications. It contains the docker daemon, images, containers, networks, and storage.
  - **Docker Registry**:-  
    Docker Registry manages and stores the Docker images.
    There are two types of registries in the Docker -
    - _Public Registry_ - Public Registry is also called as Docker hub.
    - _Private Registry_ - It is used to share images within the enterprise.
  - **Docker Objects**:-   
    There are the following Docker Objects -
    - **Docker Images**:-
      Docker images are the read-only binary templates used to create Docker Containers. It uses a private container registry to share container images within the enterprise and also uses public container registry to share container images within the whole world. Metadata is also used by docket images to describe the container's abilities.
    - **Docker Containers**:- 
    Containers are the structural units of Docker, which is used to hold the entire package that is needed to run the application. The advantage of containers is that it requires very less resources.
In other words, we can say that the image is a template, and the container is a copy of that template.
    - **Docker Networking**:- 
    Using Docker Networking, an isolated package can be communicated. Docker contains the following network drivers -
      - _Bridge_ - Bridge is a default network driver for the container. It is used when multiple docker communicates with the same docker host.
      - _Host_ - It is used when we don't need for network isolation between the container and the host.
      - _None_ - It disables all the networking.
      - _Overlay_ - Overlay offers Swarm services to communicate with each other. It enables containers to run on the different docker host.
      - _Macvlan_ - Macvlan is used when we want to assign MAC addresses to the containers.
    - **Docker Storage**:-  
    Docker Storage is used to store data on the container. Docker offers the following options for the Storage -
      - _Data Volume_ - Data Volume provides the ability to create persistence storage. It also allows us to name volumes, list volumes, and containers associates with the volumes.
      - _Directory Mounts_ - It is one of the best options for docker storage. It mounts a host's directory into a container.
      - _Storage Plugins_ - It provides an ability to connect to external storage platforms.
      

### **Docker Taxonomy**

![image](https://user-images.githubusercontent.com/84464752/196916179-2bd496ce-5ff4-422a-bfc8-bebce7114c43.png)

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
## **Working with Images and Container**

### **Installing Docker for Windows / Mac Desktop**
