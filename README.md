# SmartPlantCareApp

**SmartPlantCareApp** is a project designed to monitor and manage plant care intelligently using sensor data. It leverages IoT technology to collect environmental metrics such as soil moisture, temperature, and light intensity to ensure optimal plant health.

## Features

- **Real-time Monitoring**: Collects live data from sensors to monitor plant conditions.
- **Automated Alerts**: Sends alerts when a plant requires attention (e.g., low soil moisture, inadequate sunlight).
- **User Dashboard**: Displays real-time data for users to track plant health.
- **Historical Data**: Stores data to allow users to view trends over time.
- **Custom Notifications**: Users can set thresholds for when they would like to receive alerts.

## Technologies Used

- **Frontend**: React TypeScript
- **Backend**: ASP.NET Core Web API
- **Database**: AWS-hosted SQL Database
- **Data Visualization**: Chart.js (or any other you are using)
- **IDE**: Visual Studio
- **Version Control**: Git & GitHub

## Setup Instructions

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/Monte-Ntuli/SmartPlantCareApp.git
   cd SmartPlantCareApp
   ```

2. **Backend Setup**:
   - Open the backend project (`SmartPlantCareAPI`) in Visual Studio.
   - Ensure you have ASP.NET Core SDK installed.
   - Restore the required NuGet packages:
     ```bash
     dotnet restore
     ```
   - Update the `appsettings.json` with your AWS database credentials.

3. **Frontend Setup**:
   - Navigate to the `frontend` folder.
   - Install the necessary packages:
     ```bash
     npm install
     ```
   - Start the frontend development server:
     ```bash
     npm start
     ```

4. **Database Setup**:
   - Ensure the database is properly hosted on AWS.
   - Update connection strings in the backend project to point to your AWS database.

5. **Running the Application**:
   - Run the backend API in Visual Studio (`Ctrl + F5`).
   - In a separate terminal, start the frontend using `npm start`.
   - The frontend should be accessible on `http://localhost:3000`, and it will interact with the API hosted locally or on a cloud server.

## Contributing

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/your-feature-name`).
3. Commit your changes (`git commit -m 'Add your feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License.
