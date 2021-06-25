//Packages
import React from "react";
import { StyleSheet, View, Text, FlatList } from "react-native";
import { LinearGradient } from "expo-linear-gradient";

//Components
import { Button } from "../components/Button";

export function Profile() {
  return (
    <View style={styles.container}>
      <View style={styles.main}>
        <Text style={styles.title}>Perfil</Text>
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
    flex: 1,
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
