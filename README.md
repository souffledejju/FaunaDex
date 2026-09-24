# FaunaDex - Interactive AR Animal Encyclopedia 🦁📱

FaunaDex is an interactive educational application developed using Unity, C#, and Vuforia Engine that leverages Augmented Reality (AR) to provide an engaging, immersive way to learn about diverse animal species, their unique characteristics, and natural habitats.

---

## 📌 Problem Background

Traditional animal learning methods often struggle to capture learner engagement and provide intuitive spatial understanding:
* **Passive Learning Modalities:** Textbooks and static encyclopedias lack the interactive depth required to visualize animal behaviors, dimensions, and real-world proportions.
* **Limited Engagement:** Conventional digital media rarely provides tactile or spatial interactions, leading to lower retention rates among students and wildlife enthusiasts.
* **Disconnected Context:** Learning about animal habitats often occurs in isolation without immediate, sensory-driven feedback like visual scale and auditory cues.

---

## 💡 Proposed Solution

Building an interactive **Augmented Reality (AR) Encyclopedia** that brings 3D wildlife models into physical spaces, pairing spatial observation with curated auditory guidance and interactive informational cards to make zoological education immersive and fun.

---

## ✨ Key Features

* **Target-Based AR Tracking:**
  Seamlessly detects image targets to project high-fidelity 3D animal models into the real-world environment using the Vuforia Engine.

* **Interactive Animal Cards:**
  Intuitive UI overlays delivering concise facts, taxonomy, conservation statuses, and biological traits for each showcased species.

* **Immersive Audio & Voice-Over Integration:**
  Curated species soundbites and descriptive voice-overs that guide learners through animal behaviors and natural habitats.

* **Gesture & Spatial Interaction:**
  Smooth 3D model inspection supporting real-time rotation, scaling, and spatial repositioning.

---

## 🛠️ Tech Stack & Technical Distribution

Engineered with modern interactive media and AR development standards:
* **Game Engine:** Unity (3D Environment & Physics Pipeline).
* **Augmented Reality Engine:** Vuforia Engine (Image Targets & AR Tracking).
* **Programming Language:** C# (Component scripting, tracking callbacks, and event listeners).
* **UI/UX & Multimedia:** Figma (Animal card layouts & HUD design), curated 3D assets, and custom-sourced audio.

---

## 👥 Development Team & Contributions

Collaboratively built by:

* **Joseph Aurelio Hendarto**
  * Role: *UI/UX Designer & Multimedia Specialist*
  * Contributions: 3D asset selection and optimization, voice-over sourcing and audio integration, and interactive animal card interface design.

* **[maxwellcandra](https://github.com/maxwellcandra)**
  * Role: *AR Developer*
  * Contributions: Vuforia target database configuration, AR camera management, and tracking lifecycle scripting.

* **[Edbert-LY](https://github.com/Edbert-LY)**
  * Role: *Core Logic & Interaction Developer*
  * Contributions: UI state handling, 3D model manipulation scripts (pinch-to-scale, rotate), and scene navigation.

---

## 🚀 Local Setup Instructions

### Prerequisites
* Unity Editor (Version recommended: 2022.3 LTS or newer).
* Vuforia Engine Package installed via Unity Package Manager.

1. **Clone this repository:**
   ```bash
   git clone [https://github.com/souffledejju/FaunaDex.git](https://github.com/souffledejju/FaunaDex.git)
2.  Open the project:\
  * Launch Unity Hub, click Add, and select the cloned FaunaDex folder.
3. Configure AR Camera & Targets:
  * Open the primary scene located under Assets/Scenes/.
  * Ensure your Vuforia Developer License Key is set in Window > Vuforia Configuration.
4. Build & Run:
  * Connect an Android or iOS device with camera permissions enabled and deploy the build.
