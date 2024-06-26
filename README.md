## Getting Started

### Dependencies
To build and run our project, you will need to set up several third-party tools, libraries, SDKs, and APIs. Below is a list of the primary dependencies you will need. Some of these may have additional dependencies, which will be installed automatically during setup.

1. **Unity**: The main platform for developing our application.
   - [Unity Download](https://unity.com/download)

2. **YOLO-X CV Model**: Used for real-time object recognition.
   - [YOLO X Model](https://pjreddie.com/darknet/yolo/)

3. **AWS Polly**: This service provides audio output capabilities.
   - [AWS Polly Documentation](https://aws.amazon.com/polly/)

4. **iPhone AR Kit**: Essential for augmented reality features on iOS devices.
   - [ARKit Overview](https://developer.apple.com/augmented-reality/arkit/)

5. **OpenAI Whisper**: For audio processing and recognition.
   - [Whisper Model Information](https://openai.com/research/whisper)

6. **OpenAI GPT-4 Omni**: For integrating advanced AI functionalities.
   - [GPT-4 Omni API Guide](https://platform.openai.com/docs/guides/gpt)

7. **Google Cloud Translation API**: Facilitates the translation of text between languages.
   - [Google Cloud Translation API](https://cloud.google.com/translate)

### Building and Running the Project
To start with our project, follow these steps:
- **Step 1:** Download and install Unity.
- **Step 2:** Clone the project repository from GitHub to your local machine and build in the Unity.
- **Step 3:** Open the `.xcoderproject` which you got from the build folder and build it gain in Xcode to handle specific iOS build configurations.
- **Step 4:** Run the application on your local iOS device.

For detailed instructions on each step, refer to our setup guide (Link to detailed setup guide).


## Model and Engine

### Overview
This section outlines the engine architecture of our LinguAR application, detailing how various components such as the AI assistant, object recognition, and translation features work together to enhance the user experience in learning new languages through augmented reality.

### Engine Architecture
Our application integrates multiple technologies to create an immersive AR learning environment. Below is an overview of the main components:

![Engine Architecture](./EngineArchitecture.png)

#### Key Components:
- **AI Assistant**: Uses GPT-4O to facilitate voice and text-based interactions.
- **Real Scene Recognition**: Employs the YOLO X model for dynamic object recognition.
- **Translation Features**: Utilizes Google Cloud Translation and AWS Polly for real-time text and voice translations.
- **AR Kit**: Supports augmented reality elements through iOS ARKit.

### StoryMaps
The development of our application is planned in phases, each adding layers of functionality and interactivity:

![StoryMap1](./StoryMap1.png) ![StoryMap2](./StoryMap2.png)

#### Development Stages:
- **Object Recognition**: Starting with basic object identification moving to enhanced recognition with external database support.
- **AR-Camera Practice**: Incorporating basic AR exercises to advanced interactive feedback mechanisms.
- **Game-based Learning**: Introducing a simple AR shooting game evolving into a complex system with scoring and personalized challenges.
- **Feedback & Progress Tracking**: From basic performance metrics to AI-generated study plans and detailed analytics.


## APIs and Controller

### Overview
This section outlines how our front-end interfaces with the engine and third-party APIs to deliver a seamless augmented reality and language learning experience. Our design facilitates real-time interactions, translations, and augmented reality gaming.

### API and Interface Details

#### 1. Real-Time Object Recognition Interface
- **API**: Object Recognition API
- **Description**: This interface uses the camera input to call the YOLOX model, which recognizes and labels objects in real time.
- **Endpoint**: `/api/object-recognition`
- **Method**: POST
- **Data Input**: Camera feed
- **Data Output**: Identified objects with labels
- **Third-party Integration**: Utilizes the YOLOX model for processing the visual data.
- **User Interaction**: When a user taps on an object, the system fetches the object’s label and proceeds to the translation stage.

#### 2. Translation and Speech Output Interface
- **API**: Translation and Voice Output API
- **Description**: After object recognition, this interface handles text translation via Google Cloud Translation API and speech output via AWS Polly.
- **Endpoint**: `/api/translate-and-speak`
- **Method**: POST
- **Data Input**: Text string of the object label
- **Data Output**: Translated text and audio pronunciation
- **Third-party Integration**: Google Cloud Translation for text translation and AWS Polly for converting text to speech.

#### 3. Augmented Reality Gaming Interface
- **API**: AR Game Control API
- **Description**: This interface displays AR objects and allows users to interact with them in a language learning game using the ARKit.
- **Endpoint**: `/api/ar-game-control`
- **Method**: POST
- **Data Input**: User interactions with AR elements
- **Data Output**: Game state updates
- **Third-party Integration**: Apple ARKit is used to manage AR elements and interactions.

#### 4. AI Assistant Interface
- **API**: AI Interaction API
- **Description**: Facilitates voice and text interactions with an AI assistant powered by the GPT-4O API, aimed at teaching language conversational skills.
- **Endpoint**: `/api/ai-assistant`
- **Method**: POST
- **Data Input**: User voice or text input
- **Data Output**: AI-generated voice or text response
- **Third-party Integration**: Utilizes OpenAI's GPT-4O API for generating responses.

### Front-end Communication
Each front-end interface communicates with our engine via defined APIs that handle specific tasks like object recognition, translation, AR interactions, and AI-based tutoring. These interfaces ensure that our application is interactive, engaging, and educational, providing a rich user experience in learning new languages through augmented reality.


## View UI/UX


## Team Roster and Contributions

### Overview
Our team consists of skilled individuals who each bring unique strengths to the LinguAR project. This roster outlines the roles and key contributions of each member, highlighting how their efforts collectively push our project towards its objectives.

### Team Members

- **Jin Pan**
  - **jAccount**: panjin1221
  - **Role**: AR Research, OpenAI Integration, Accessibility Features
  - **Technical Strengths**: UI/UX, Unity, C#, Python, Lua, Web Development

- **Yuewen Hou**
  - **jAccount**: ithaca2020
  - **Role**: Usability Testing, Backend Development
  - **Technical Strengths**: C++, Java, Python, JavaScript, Elm

- **Jiahui Wang**
  - **jAccount**: chewchew
  - **Role**: Front End, UI/UX Design
  - **Technical Strengths**: C#, C++, Python, Unity

- **Yifan Hu**
  - **jAccount**: huyifan_2002
  - **Role**: Usability Testing, Accessibility Features
  - **Technical Strengths**: C#, Python, C++

- **Shufeng Chen**
  - **jAccount**: Alex725
  - **Role**: AR Research, API Integration, UI/UX Design
  - **Technical Strengths**: Unity, C#, Python, Lua

- **Tao Zhu**
  - **jAccount**: gensofubi
  - **Role**: AR Research, Backend Deployment
  - **Technical Strengths**: Unity, C#, JavaScript, Cloud Deployment

### Sub-Teams

- **AR AI Tutor**
  - **Team Members**: Jin Pan, Yifan Hu, Jiahui Wang
  - **Task**: Development of an AR-based AI Tutor application

- **AR Shooting Game**
  - **Team Members**: Tao Zhu, Shufeng Chen
  - **Tasks**: Enhance screen dynamics, integrate engaging feedback mechanisms, develop interactive bullet models

- **Multimodal Output Fixes**
  - **Team Member**: Jin Pan
  - **Task**: Enhancements and fixes to the multimodal output features using Google Cloud Translation and AWS Polly

This roster reflects the collaborative spirit and technical diversity of our team, showcasing each member’s contributions toward developing an innovative AR language learning platform.




