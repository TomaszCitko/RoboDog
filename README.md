<h1>RoboDog</h1>

If tiny, friendly aliens came to Earth, they would definitely fall in love with dogs. The only problem would be that they wouldn't have them on their home planet. They would surely ask Codecool to help them automate, by creating Robo-Dogs and populating their planet with four-legged friends. Let's prepare for this case, and bring peace to the universe! 🐾

<h2>TASKS</h2>
<h3>Setup the project</h3>

When the project repository is cloned, it only contains a README.md file. Set up the project for RoboDogApplication.

<h3>Create a model to describe a dog</h3>

The application can model a dog by its age, name, and breed. This class is located in the Models folder.

<h3>Logic for creating dogs</h3>

There is a DogCreator class in the Services folder, which contains a @CreateRandomDog() method.


<h3>Dog storage</h3>

Who let the dogs out? Let's shelter them! Create a DogStorage class for handling the dogs.

<h3>GET a pet!</h3>

Create a DogController class in the Controllers folder to let others interact with the dogs. This controller must contain methods to get all dogs, create a random dog, add a specific dog, or update the first dog of a given name. To achieve this behavior, this class must not contain the full logic in itself. Instead, it must be wired with another class responsible for such services.

<h3>Check your dogs</h3>

Use Postman to check your endpoints. Create a new Postman collection for this project, and create requests for testing all your endpoints inside this collection. Use JSON format for testing POST requests.


