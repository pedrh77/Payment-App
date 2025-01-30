# Payment System

## Overview
This project is a simple payment system that allows users to perform secure financial transactions. It includes features such as user registration, virtual wallets, money transfers, transaction history, and basic security measures.

## Features
### 1. User Registration
- Users can register with:
  - Full Name
  - Email (must be unique)
  - Password (securely hashed)

### 2. Virtual Wallet
- Each user has a virtual wallet with an initial balance of **$0.00**.
- Users can increase their balance via simulated deposits.

### 3. Make Payments
- Users can transfer money to other registered users.
- Transaction details include:
  - Sender ID
  - Receiver ID
  - Transaction amount
  - Date/time of the transaction
- System validations ensure:
  - The sender has sufficient funds.
  - The recipient exists.
  - No negative-value transactions are allowed.

### 4. Transaction History
- Users can view:
  - Sent transactions
  - Received transactions

### 5. Security
- Passwords are securely hashed.
- Basic fraud prevention is implemented.

## Technology Stack
### Backend:
- **C#** 

### Database:
- **MySQL**, **PostgreSQL**, or **MongoDB**

### Optional Frontend:
- **React** OR **Vue.js**

## API Endpoints
### Authentication
- `POST /register` - Register a new user
- `POST /login` - Authenticate and receive a token (if JWT is implemented)

### Wallet
- `GET /wallet` - Retrieve user wallet balance
- `POST /wallet/deposit` - Simulate adding funds

### Transactions
- `POST /transactions/send` - Transfer money to another user
- `GET /transactions/history` - View transaction history

## Setup & Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/payment-system.git
   cd payment-system
   ```
2. Install dependencies:
   ```sh
   npm install  # For Node.js
   pip install -r requirements.txt  # For Python
   ```
3. Configure the database connection in `.env` file.
4. Run the server:
   ```sh
   npm start  # For Node.js
   python app.py  # For Flask
   ```
5. (Optional) Start the frontend:
   ```sh
   npm run dev  # For React or Vue.js
   ```

## Bonus Features (Optional)
- JWT Authentication
- Integration with external APIs (Stripe, PayPal, Pix)
- Frontend UI for better user interaction

## Contribution
Feel free to fork this repository and submit pull requests with improvements.

## License
MIT License

