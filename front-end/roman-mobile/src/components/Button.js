//Packages
import React from "react";
import { StyleSheet, Text, TouchableOpacity } from "react-native";

export function Button({ children, onPress }) {
  return (
    <TouchableOpacity style={styles.button} onPress={onPress}>
      <Text style={styles.buttonText}>{children}</Text>
    </TouchableOpacity>
  );
}

const styles = StyleSheet.create({
  button: {
    marginTop: "auto",
    marginRight: "auto",
    marginBottom: 25,
    marginLeft: "auto",
    backgroundColor: "#49A2C2",
    width: 167.5,
    height: 60,
    alignItems: "center",
    justifyContent: "center",
    borderRadius: 6,
  },

  buttonText: {
    color: "#fff",
    fontSize: 18,
  },
});
