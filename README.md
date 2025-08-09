# 🖥️ C# from Bro Code Tutorial

*"From comfy clicky IDEs to raw terminal brain-burners"*

> **📌 Reader's Note**  
> Before diving in, please **read carefully** and **follow each tutorial step-by-step**.  
> Take a moment to **understand** *why* the code works instead of just *what* it does — it'll save you headaches later.  
> And please, **don't just copy my whole code** blindly. Tweak it, break it, fix it again — that's how you actually learn.

## 📑 Table of Contents

1. [Beginner-Friendly IDEs](#1--beginner-friendly-ides)
2. [General-Purpose IDEs for All Skill Levels](#2--general-purpose-ides-for-all-skill-levels)
3. [Lightweight Editors for Fast Coding](#3--lightweight-editors-for-fast-coding)
4. [Terminal-Based Hardcore Editors](#4--terminal-based-hardcore-editors)
5. [Full-Time CLI Workflows](#5--full-time-cli-workflows)
6. [Quick Summary Table](#6--quick-summary-table)
7. [Setting Up to Run BroCode C# Code](#setting-up-to-run-brocode-c-code)
8. [C# Tutorial Video Index](#c-tutorial-for-beginners--full-video-index-150)

---

## 1. 🐣 Beginner-Friendly IDEs

For those who want *"it just works"* energy.

- **VS Code** – Easiest setup, loads of extensions, cross-platform.
- **Cursor** – AI-focused VS Code fork, snappy and integrated with AI tools.
- **Zed (Linux Beta)** – Modern, minimalist, super-fast.
- **VSCodium** – VS Code without Microsoft telemetry.

---

## 2. 🛠️ General-Purpose IDEs for All Skill Levels

The all-rounders — good for Python, C++, Java, web dev, and more.

- **JetBrains Fleet** – Cloud + local hybrid IDE.
- **JetBrains IntelliJ IDEA Community** – Great for Java/Kotlin.
- **Eclipse IDE** – Classic Java/C++/Python support.
- **Geany** – Very lightweight but feature-rich for multiple languages.

---

## 3. ⚡ Lightweight Editors for Fast Coding

For when you want speed but still have a mouse.

- **Sublime Text** – Fast, elegant, multi-language, great keyboard workflow.
- **Kate** – KDE's lightweight but powerful text editor.
- **Mousepad** – XFCE's ultra-minimal text editor.

---

## 4. ⌨️ Terminal-Based Hardcore Editors

For when you're ready to scare normal people.

- **Neovim** – Modern Vim, scriptable in Lua, infinite customizability.
- **Vim** – The OG modal editor, runs everywhere.
- **Micro** – A terminal editor with normal keybindings for sanity.

---

## 5. 🖤 Full-Time CLI Workflows

The "Linux wizard" experience.

- **Helix** – Modal editor like Vim but saner defaults.
- **Emacs (Doom/Spacemacs)** – Text editor turned operating system.
- **Kakoune** – Minimalist but command-rich modal editor.

---

## 6. 📊 Quick Summary Table

| Tool             | Type           | Best For                 | Pros                           | Cons                      |
| ---------------- | -------------- | ------------------------ | ------------------------------ | ------------------------- |
| **VS Code**      | GUI IDE        | Beginners to pros        | Huge ecosystem, easy setup     | Electron RAM usage        |
| **VSCodium**     | GUI IDE        | Privacy-focused devs     | No telemetry, VS Code features | Updates lag slightly      |
| **Cursor**       | GUI IDE        | AI-assisted coding       | Fast, AI features              | Early-stage Linux support |
| **Zed**          | GUI IDE        | Minimal + fast coding    | Slick UI, low latency          | Still beta on Linux       |
| **Sublime Text** | GUI Editor     | Speed & custom workflows | Very fast, good plugin system  | Paid license              |
| **Neovim**       | TUI Editor     | Hardcore coders          | Lua config, blazing fast       | Steep learning curve      |
| **Helix**        | TUI Editor     | Modern modal editing     | Simple config, fast            | Smaller plugin ecosystem  |
| **Emacs**        | TUI/GUI Hybrid | Power users              | Infinite extensibility         | Steep learning + heavy    |
| **Kate**         | GUI Editor     | KDE fans                 | Lightweight, good features     | KDE dependencies          |

---

# 🖥 Setting Up to Run BroCode C# Code

Since BroCode's C# code is built to run on **.NET**, we'll set up the **latest LTS version (.NET 8.0)** for maximum compatibility and performance.

## 1️⃣ Install .NET 8.0 LTS

### Windows

1. Go to the official .NET download page:  
   🔗 [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. Download **.NET SDK 8.0 (LTS)** → choose *Windows x64 Installer*.
3. Install it and restart your terminal (PowerShell, cmd, or Windows Terminal).

### Linux

**Arch Linux / Manjaro**
```bash
sudo pacman -S dotnet-sdk dotnet-runtime
```

**Ubuntu / Debian**
```bash
sudo apt update
sudo apt install -y dotnet-sdk-8.0
```

### macOS

```bash
brew install --cask dotnet-sdk
```

## 2️⃣ Verify Installation

```bash
dotnet --version
```

If it shows `8.x.x`, you're good to go.

## 3️⃣ Run C# Code (BroCode Style)

If your file is named `Program.cs`:

```bash
dotnet new console -o MyApp
cd MyApp
# replace Program.cs with BroCode's file
dotnet run
```

## 4️⃣ Optional – Install Mono

Mono lets you run older .NET Framework code that isn't compatible with modern .NET:

```bash
# Arch
sudo pacman -S mono

# Ubuntu
sudo apt install mono-complete
```

## TL;DR

- Install **.NET SDK 8.0 LTS** (core requirement for BroCode's modern C# code).
- Use **Mono** only if you need legacy compatibility.
- Run `dotnet run` inside your project folder to execute the program.

---

# C# Tutorial for Beginners — Full Video Index (1–50)

1. **C# tutorial for beginners**
2. **C# output 💬**
3. **C# variables ✖️**
4. **C# constants π**
5. **C# type casting 💱**
6. **C# user input ⌨️**
7. **C# arithmetic operators 🧮**
8. **C# Math class 📏**
9. **C# random numbers 🎲**
10. **C# hypotenuse calculator program 📐**
11. **C# string methods 🔤**
12. **C# if statements 🤔**
13. **C# switches 🔀**
14. **C# logical operators && || 🔣**
15. **C# while loops ♾️**
16. **C# for loops 🔁**
17. **C# nested loops ➿**
18. **C# number guessing game 🔢**
19. **C# rock-paper-scissors game 🗿**
20. **C# calculator program 🖩**
21. **C# arrays 🚗**
22. **C# foreach loop ➰**
23. **C# methods 📞**
24. **C# return keyword ↩️**
25. **C# method overloading 🤯**
26. **C# params keyword ⚙️**
27. **C# exception handling ⚠️**
28. **C# conditional operator ❓**
29. **C# string interpolation 💲**
30. **C# multidimensional arrays ⬜**
31. **C# classes 📦**
32. **C# objects 🧍‍♂️**
33. **C# constructors 👷**
34. **C# static 🚫**
35. **C# overloaded constructors 🍕**
36. **C# inheritance 👪**
37. **C# abstract classes 👻**
38. **C# array of objects 🏬**
39. **C# objects as arguments 🧳**
40. **C# method overriding 🙅**
41. **C# ToString method 💭**
42. **C# polymorphism 🎭**
43. **C# interfaces 🐟**
44. **C# Lists 📃**
45. **C# List of objects 🦸‍♂️**
46. **C# getters & setters 🔒**
47. **C# auto implemented properties 🔐**
48. **C# enums 🪐**
49. **C# generics ⁉️**
50. **C# multithreading 🧶**
