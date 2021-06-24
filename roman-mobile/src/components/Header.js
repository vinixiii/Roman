import React from "react";
import { StyleSheet, Text, View } from "react-native";

import { Logo } from "../assets/images/Logo";

export function Header({ secondaryPageTitle }) {
  return (
    // <View style={styles.container}>
    <View style={styles.header}>
      {!secondaryPageTitle ? (
        <Logo style={styles.logo} />
      ) : (
        <Text style={styles.headerTitle}>{secondaryPageTitle}</Text>
      )}
      <Text style={styles.headerText}>Olá, professor(a) Vinícius!</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  header: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
  },

  logo: {
    width: 40,
    height: 40,

    shadowColor: "#000",
    shadowOffset: {
      width: 0,
      height: 1,
    },
    shadowOpacity: 0.22,
    shadowRadius: 2.22,

    elevation: 3,
  },

  headerTitle: {
    fontSize: 22,
    color: "#33547D",
  },

  headerText: {
    fontSize: 16,
    color: "#7593b6",
  },
});
