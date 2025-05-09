import React, { useState } from "react";
import { Link } from "react-router-dom"; // Use Link for navigation
import { generateID, downloadID } from "./idUtils"; // Ensure these functions are properly imported
import IDCardPreview from "./IDCardPreview"; // Import the IDCardPreview component
import styles from './GenarateID.module.css'; 
const GenerateID = () => { 
  const [idImage, setIdImage] = useState(null);
  const [loading, setLoading] = useState(false);

  return (
    <div className={styles.container}>
      <h1 className={styles.title}>Generate ID</h1>

      {loading ? (
        <div className={styles.loader}>
          Generating your Visual ID. Please wait... {/* The added text during loading */}
        </div>
      ) : (
        <div>
          {idImage && <IDCardPreview idImage={idImage} />} 
          <button
            onClick={() => downloadID(idImage)} // Download the generated ID image
            disabled={!idImage} // Disable button if there's no generated image
            className={styles.downloadButton}
          >
            Download ID
          </button>
        </div>
      )}

      <button
        onClick={() => {
          setLoading(true); // Set loading to true when the Generate ID button is clicked
          generateID(setIdImage, setLoading); // Call the function to generate ID
        }}
        className={styles.generateButton}
      >
        Generate ID
      </button>

      {/* Back to Dashboard button with Link for navigation */}
      <Link to="/dashboard_back">
        <button className={styles.backButton}> {/* Navigate to the dashboard */}
          Back to Dashboard
        </button>
      </Link>
    </div>
  );
};

export default GenerateID;
