# XTS C# Client Assignment

A C# implementation inspired by the `xts-api-client` Python package.  
This project demonstrates understanding of REST APIs, async workflows, request/response models, and WebSocket streaming architecture for algorithmic trading systems.

---

## 📌 Objective

The goal of this assignment is **NOT** to fetch real market data, but to:
- Understand the architecture of the XTS API client
- Design clean C# request/response models
- Implement REST and WebSocket workflows (skeleton-based)
- Demonstrate async programming and modular service design

---

## ✅ Implemented Features

### 1️⃣ Market Data Login
- REST-style login flow
- Structured request and response models
- Async implementation with exception handling

---

### 2️⃣ Equity OHLC Data (Cash Market)
- OHLC data structure for **Top Nifty stocks**
- Clean separation of request/response models
- Async service method simulating API workflow

---

### 3️⃣ Futures OHLC (Near Month, 1-Minute) ✅
> **Skeleton Implementation (As Expected)**

- Supports **Near Month Futures**
- 1-minute interval structure
- No real F&O data used
- Focus on:
  - Request model
  - Response model
  - Async service method

This matches the assignment requirement precisely.

---

### 4️⃣ WebSocket Streaming (Skeleton) ✅
> **Lifecycle-based implementation**

- Connect
- Subscribe
- Receive data
- Disconnect

No real XTS socket or live ticks are used.  
The goal is to demonstrate understanding of **streaming architecture**, not live data consumption.

---

## 🧱 Project Structure

```text
├── Models
│   ├── LoginRequest.cs
│   ├── LoginResponse.cs
│   ├── OhlcRequest.cs
│   ├── OhlcResponse.cs
│   ├── FuturesOhlcRequest.cs
│   └── FuturesOhlcResponse.cs
│
├── Services
│   ├── MarketDataService.cs
│   └── SocketService.cs
│
├── Utils
│   └── AppConfig.cs
│
├── Program.cs
├── XtsClient.csproj
└── README.md

---

## 🧪 How to Run

Ensure you have **.NET SDK (6.0 or above)** installed.

```bash
dotnet restore
dotnet build
dotnet run
