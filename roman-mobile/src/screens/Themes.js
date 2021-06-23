//Packages
import React from "react";
import { StyleSheet, View, Text } from "react-native";

//Components
// import { Header } from "../components/Header";

export function Temas() {
  return (
    <View style={styles.container}>
      {/* <Header /> */}

      <View style={styles.main}>
        <Text style={styles.title}>Temas</Text>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#F6F7F9",
    flex: 1,
  },

  main: {
    paddingLeft: 20,
    paddingRight: 20,
  },

  title: {
    fontSize: 28,
    color: "#33547D",
    marginTop: 25,
    marginBottom: 25,
  },
});
